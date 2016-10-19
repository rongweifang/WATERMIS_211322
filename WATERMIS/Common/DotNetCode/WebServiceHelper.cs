﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.ServiceModel.Description;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Web.Services.Description;

public class WebServiceHelper
{
    #region InvokeWebService

    //调用方法
    //object[] args = new object[1];
    //    args.SetValue("cyy_JS", 0);
    //    DataTable dt = WebServiceHelper.InvokeWebService("http://192.168.0.10/DBMS_CYY/DBMS_Service.asmx", "GetUserTreeListData", args) as DataTable;

    // object[] args = new object[1];
    //          args.SetValue(xml.Element("TicketsNO").Value, 0);
    // string isvaild = WebServiceHelper.InvokeWebService(Config.GetWebserviceURL, "IsVaildTicketNO", args).ToString();
    //动态调用web服务
    public static object InvokeWebService(string url, string methodname, object[] args)
    {
        return WebServiceHelper.InvokeWebService(url, null, methodname, args);
    }

    public static object InvokeWebService(string url, string classname, string methodname, object[] args)
    {
        string @namespace = "EnterpriseServerBase.WebService.DynamicWebCalling";
        if ((classname == null) || (classname == ""))
        {
            classname = WebServiceHelper.GetWsClassName(url);
        }

        try
        {
            //获取WSDL
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead(url + "?WSDL");
            System.Web.Services.Description.ServiceDescription sd = System.Web.Services.Description.ServiceDescription.Read(stream);
            ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
            sdi.AddServiceDescription(sd, "", "");
            CodeNamespace cn = new CodeNamespace(@namespace);

            //生成客户端代理类代码
            CodeCompileUnit ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(cn);
            sdi.Import(cn, ccu);
            CSharpCodeProvider csc = new CSharpCodeProvider();
            ICodeCompiler icc = csc.CreateCompiler();

            //设定编译参数
            CompilerParameters cplist = new CompilerParameters();
            cplist.GenerateExecutable = false;
            cplist.GenerateInMemory = true;
            cplist.ReferencedAssemblies.Add("System.dll");
            cplist.ReferencedAssemblies.Add("System.XML.dll");
            cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
            cplist.ReferencedAssemblies.Add("System.Data.dll");

            //编译代理类
            CompilerResults cr = icc.CompileAssemblyFromDom(cplist, ccu);
            if (true == cr.Errors.HasErrors)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
                {
                    sb.Append(ce.ToString());
                    sb.Append(System.Environment.NewLine);
                }
                throw new Exception(sb.ToString());
            }

            //生成代理实例，并调用方法
            System.Reflection.Assembly assembly = cr.CompiledAssembly;
            Type t = assembly.GetType(@namespace + "." + classname, true, true);
            object obj = Activator.CreateInstance(t);
            System.Reflection.MethodInfo mi = t.GetMethod(methodname);

            return mi.Invoke(obj, args);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.InnerException.Message, new Exception(ex.InnerException.StackTrace));
        }
    }

    private static string GetWsClassName(string wsUrl)
    {
        string[] parts = wsUrl.Split('/');
        string[] pps = parts[parts.Length - 1].Split('.');

        return pps[0];
    }
    #endregion

}
