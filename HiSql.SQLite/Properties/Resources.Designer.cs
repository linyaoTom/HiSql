﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiSql.Sqlite.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HiSql.Sqlite.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 declare @_effect int
        ///if not Exists(select top 1 * from dbo.sysObjects where Id=OBJECT_ID(N&apos;Hi_TabModel&apos;) and xtype=&apos;U&apos;)
        ///begin
        ///	CREATE TABLE [[$Schema$]].[Hi_TabModel] (
        ///	[TabName] [nvarchar](50) NOT NULL   , 
        ///	[TabReName] [nvarchar](50) NULL  default (&apos;&apos;) , 
        ///	[TabDescript] [nvarchar](100) NULL  default (&apos;&apos;) , 
        ///	[TabStoreType] [int]  NULL default ((0)) ,
        ///	[TabType] [int]  NULL default ((0)) ,
        ///	[TabCacheType] [int]  NULL default ((0)) ,
        ///	[TabStatus] [int]  NULL default ((0)) ,
        ///	[IsSys] [bit]   NULL [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string HiSql {
            get {
                return ResourceManager.GetString("HiSql", resourceCulture);
            }
        }
    }
}
