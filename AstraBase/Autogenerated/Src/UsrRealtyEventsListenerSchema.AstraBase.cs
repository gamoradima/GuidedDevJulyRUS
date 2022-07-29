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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,72,73,4,65,0,125,203,147,163,7,0,0,0 };
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

