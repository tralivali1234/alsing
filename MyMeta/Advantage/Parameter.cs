using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Advantage
{

	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IParameter))]

	public class AdvantageParameter : Parameter
	{
		public AdvantageParameter()
		{

		}

		override public string DataTypeNameComplete
		{
			get
			{
				switch(this.TypeName)
				{
					case "binary":
					case "char":
					case "nchar":
					case "nvarchar":
					case "varchar":
					case "varbinary":

						return this.TypeName + "(" + this.CharacterMaxLength + ")";

					case "decimal":
					case "numeric":

						return this.TypeName + "(" + this.NumericPrecision + "," + this.NumericScale + ")";

					default:

						return this.TypeName;
				}
			}
		}
	}
}
