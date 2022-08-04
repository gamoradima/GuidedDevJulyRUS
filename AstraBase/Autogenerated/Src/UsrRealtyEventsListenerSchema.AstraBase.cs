namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsListenerSchema

	/// <exclude/>
	public class UsrRealtyEventsListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsListenerSchema(UsrRealtyEventsListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9aaeeb95-7eee-40a3-9927-9d890cc9bc0a");
			Name = "UsrRealtyEventsListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cf45bd05-40ec-430c-a376-79d38514e55a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,95,75,195,48,20,197,223,7,251,14,151,226,67,11,18,182,87,167,3,55,135,12,68,197,77,95,196,135,52,185,237,34,105,82,146,116,179,200,190,187,105,179,177,238,207,131,247,165,205,205,185,191,156,147,86,209,2,109,73,25,194,18,141,161,86,103,142,76,181,202,68,94,25,234,132,86,253,222,111,191,7,190,42,43,84,14,139,218,58,44,70,221,86,119,208,32,153,41,39,156,64,251,31,13,153,173,81,185,70,26,196,159,237,70,221,118,159,132,63,73,161,137,23,108,133,5,125,246,70,225,14,162,119,107,222,144,74,87,71,201,87,24,42,171,84,10,6,76,82,107,33,236,93,192,192,13,76,168,197,11,59,129,178,75,217,1,234,181,55,45,56,194,90,11,14,47,106,174,44,26,231,211,196,58,253,70,230,192,162,226,104,174,33,48,39,152,249,104,45,249,222,228,22,48,57,16,59,240,166,82,111,132,116,129,123,18,38,163,99,101,64,131,105,83,249,248,113,104,36,97,224,68,204,145,137,130,74,40,141,96,205,93,133,41,242,136,110,89,151,200,167,90,86,133,250,160,178,194,219,157,116,28,55,247,249,218,232,223,23,15,209,233,233,34,131,56,192,198,48,28,236,43,57,22,157,100,107,10,201,220,78,169,98,40,145,123,31,206,84,56,58,87,185,149,209,27,80,184,129,217,15,195,178,249,217,226,168,245,98,33,21,121,238,191,153,91,81,5,67,50,152,92,1,53,8,74,59,160,82,234,13,114,114,102,118,123,88,238,94,253,99,251,7,201,104,103,177,224,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9aaeeb95-7eee-40a3-9927-9d890cc9bc0a"));
		}

		#endregion

	}

	#endregion

}

