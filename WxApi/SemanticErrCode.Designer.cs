﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WxApi {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SemanticErrCode {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SemanticErrCode() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WxApi.SemanticErrCode", typeof(SemanticErrCode).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 0 请求正常，有语义结果
        ///7000000 请求正常， 无语义结果
        ///7000001 缺失请求参数
        ///7000002 signature 参数无效
        ///7000003 地理位置相关配置 1 无效
        ///7000004 地理位置相关配置 2 无效
        ///7000005 请求地理位置信息失败
        ///7000006 地理位置结果解析失败
        ///7000007 内部初始化失败
        ///7000008 非法 appid（获取密钥失败）
        ///7000009 请求语义服务失败
        ///7000010 非法 post 请求
        ///7000011 post 请求 json 字段无效
        ///7000030 查询 query 太短
        ///7000031 查询 query 太长
        ///7000032 城市、经纬度信息缺失
        ///7000033 query 请求语义处理失败
        ///7000034 获取天气信息失败
        ///7000035 获取股票信息失败
        ///7000036 utf8 编码转换失败 的本地化字符串。
        /// </summary>
        internal static string ErrCode {
            get {
                return ResourceManager.GetString("ErrCode", resourceCulture);
            }
        }
    }
}
