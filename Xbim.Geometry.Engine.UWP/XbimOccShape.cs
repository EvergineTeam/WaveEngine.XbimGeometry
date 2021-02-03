using System;
using System.IO;
using Xbim.Ifc4.Interfaces;
using Microsoft.Extensions.Logging;
using Xbim.Ifc4;

namespace Xbim.Geometry.Engine.UWP
{
    public abstract class XbimOccShape : XbimGeometryObject
	{
		public static void WriteIndex(BinaryWriter bw, UInt32 index, Int32 maxInt)
		{
			throw new NotImplementedException();
		}

		public XbimOccShape()
		{
			throw new NotImplementedException();
		}

		//operators
		//public abstract const TopoDS_Shape& castTopoDs();
		public abstract REF_TopoDS_Shape castTopoDs();

		public void WriteTriangulation(TextWriter textWriter, double tolerance, double deflection, double angle)
		{
			throw new NotImplementedException();
		}
		public void WriteTriangulation(BinaryWriter binaryWriter, double tolerance, double deflection, double angle)
		{
			throw new NotImplementedException();
		}

		public void WriteTriangulation(IXbimMeshReceiver mesh, double tolerance, double deflection, double angle)
		{
			throw new NotImplementedException();
		}

		public override bool IsSet
		{
			get
			{
				return false;
			}
		}
		public abstract XbimGeometryObject Transformed(IIfcCartesianTransformationOperator transformation);
		
		public abstract XbimGeometryObject Moved(IIfcPlacement placement);

		public abstract XbimGeometryObject Moved(IIfcObjectPlacement objectPlacement, ILogger logger);
		
		public virtual void Mesh(IXbimMeshReceiver mesh, double precision, double deflection, double angle)
		{
			WriteTriangulation(mesh, precision, deflection, angle);
		}
		// Inherited via XbimGeometryObject	
    }
}
