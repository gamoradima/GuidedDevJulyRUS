namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrSaveGoldRateSubProcessMethodsWrapper

	/// <exclude/>
	public class UsrSaveGoldRateSubProcessMethodsWrapper : ProcessModel
	{

		public UsrSaveGoldRateSubProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			string rate_str = Get<string>("RateStrParameter");
			rate_str = rate_str.Replace(",", "");
			if (rate_str == "") {
				rate_str = "0";
			}
			
			decimal rate = Convert.ToDecimal(rate_str);
			Set("RateParameter", rate);
			return true;
		}

		#endregion

	}

	#endregion

}

