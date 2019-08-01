﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jc.ApiHelperTest
{
    /// <summary>
    /// Xml Assembly注释
    /// </summary>
    public class AssemblyNoteModel
    {
        /// <summary>
        /// Assembly 组件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ModuleName
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// Members
        /// </summary>
        public List<MemberNoteModel> MemberList { get; set; } = new List<MemberNoteModel>();
    }

    /// <summary>
    /// MemberNote 对象
    /// </summary>
    public class MemberNoteModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        public Dictionary<string, string> ParamList { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 返回值
        /// </summary>
        public string Returns { get; set; }
    }
}
