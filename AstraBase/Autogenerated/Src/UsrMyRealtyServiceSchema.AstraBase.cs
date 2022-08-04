﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrMyRealtyServiceSchema

	/// <exclude/>
	public class UsrMyRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrMyRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrMyRealtyServiceSchema(UsrMyRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87c25d03-f3f7-4aee-8872-71f2074c3b2e");
			Name = "UsrMyRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cf45bd05-40ec-430c-a376-79d38514e55a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,81,111,218,48,16,126,78,165,254,7,43,79,161,98,233,246,186,174,147,160,133,138,73,20,212,128,120,64,123,48,201,65,173,57,118,122,62,179,69,107,255,251,236,56,176,160,77,76,123,8,193,223,119,247,221,221,119,86,20,47,193,84,60,7,182,0,68,110,244,150,210,59,173,182,98,103,145,147,208,234,242,226,231,229,69,100,141,80,59,150,213,134,160,76,51,192,189,200,97,170,11,144,55,231,200,116,5,155,243,1,131,156,196,190,169,243,59,174,219,8,66,122,63,252,27,229,148,29,93,150,221,196,80,224,143,130,62,52,3,99,92,145,140,56,129,15,88,183,93,184,81,9,121,78,95,61,54,48,213,35,144,83,173,92,71,27,33,5,213,79,240,98,5,66,9,138,76,210,61,248,246,217,45,251,71,138,143,74,91,160,232,249,34,149,221,72,145,179,92,114,99,216,19,112,73,117,219,10,251,200,134,220,64,123,234,179,137,99,139,153,146,117,183,119,167,224,215,17,173,103,21,132,253,116,39,136,214,110,214,137,218,235,111,144,76,129,158,117,225,90,140,231,179,108,17,247,217,245,213,18,197,2,202,74,58,29,143,223,113,153,103,182,140,251,87,215,140,13,117,81,103,84,75,207,56,145,169,171,201,119,112,68,211,21,242,170,130,162,239,171,68,126,34,48,52,214,88,114,58,73,8,80,250,197,104,213,119,227,153,74,43,3,231,227,188,45,94,181,117,166,128,92,148,92,178,7,160,133,38,46,7,165,182,138,134,245,162,174,96,82,36,134,208,175,22,27,231,2,214,103,39,224,108,187,5,12,76,207,235,54,126,69,98,203,218,220,116,98,30,173,148,51,28,149,21,213,73,87,169,199,94,95,217,153,168,174,116,163,221,138,71,8,100,81,177,119,31,110,154,243,91,243,123,152,4,193,88,233,199,127,31,216,12,36,228,196,76,120,221,50,5,223,89,192,146,165,1,116,11,85,238,191,91,109,40,17,185,123,46,109,169,146,177,85,121,234,22,150,196,75,131,115,116,151,100,153,221,199,189,67,212,24,117,160,194,173,138,15,248,234,25,16,26,34,116,30,247,220,108,163,23,203,101,18,132,211,57,71,247,21,32,192,196,183,242,96,69,113,234,202,177,196,64,21,141,80,199,135,255,80,59,113,175,149,228,166,29,61,88,115,180,42,152,147,142,126,64,110,9,178,156,75,142,159,90,67,63,39,189,67,116,227,122,72,106,32,111,188,123,222,126,1,174,86,85,68,214,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87c25d03-f3f7-4aee-8872-71f2074c3b2e"));
		}

		#endregion

	}

	#endregion

}

