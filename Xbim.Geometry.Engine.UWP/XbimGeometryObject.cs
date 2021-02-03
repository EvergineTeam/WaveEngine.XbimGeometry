using Xbim.Common.Geometry;
using System.Collections.Generic;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;

namespace Xbim
{
	namespace Geometry
	{
		public class XbimGeometryObjectEnumerator :IEnumerator<IXbimGeometryObject>
		{
			private IXbimGeometryObject shape;
			private bool atStart;
		

			public XbimGeometryObjectEnumerator(IXbimGeometryObject occShape)
			{
				shape = occShape;
				atStart = true;
			}

			public virtual void Dispose()
			{
				throw new NotImplementedException();
			}

			//!XbimGeometryObjectEnumerator(){}


			public virtual bool MoveNext() //there is only ever one so any move means we are at the end
			{
				atStart = false;
				return atStart;
			}

			public virtual IXbimGeometryObject Current
			{
				get
				{
					return shape;
				}
			}

            object IEnumerator.Current => shape;

            public virtual void Reset()
			{
				atStart = true;
			}
		}

		public  abstract class XbimSetObject
		{
			private Object tag;
		
			public abstract IXbimGeometryObject Transformed(IIfcCartesianTransformationOperator transformation);

			public abstract IXbimGeometryObject Moved(IIfcPlacement placement);

			public abstract IXbimGeometryObject Moved(IIfcObjectPlacement objectPlacement, ILogger logger) ;
			
			public virtual Object  Tag { get { return tag; }  set { tag = value; } }

			public abstract int Count { get; }
		
			public abstract IXbimGeometryObject Trim() ; 

			public abstract void Mesh(IXbimMeshReceiver mesh, double precision, double deflection, double angle);
		};

		public abstract class XbimGeometryObject : IXbimGeometryObject 
		{
			private Object tag;
		
			public XbimGeometryObject(){}
#region destructors

			public virtual void Dispose() {}

			//!XbimGeometryObject() {};

#endregion
			public abstract bool IsValid{ get; }

			public abstract bool IsSet{ get; }

			public abstract XbimGeometryObjectType GeometryType{get;}

			public virtual bool Equals(IXbimGeometryObject o1, double v){ throw new NotImplementedException("Function not implemented"); }

			public virtual bool Intersects(IXbimGeometryObject o1, double v){ throw new NotImplementedException("Function not implemented"); }
			
			public abstract XbimRect3D BoundingBox {get;}
			
			public abstract IXbimGeometryObject Transform(XbimMatrix3D matrix3D) ;
			
			public abstract IXbimGeometryObject TransformShallow(XbimMatrix3D matrix3D) ;
			
			public virtual string  ToBRep { get { throw new NotImplementedException(); } }
			
			public virtual Object  Tag {get =>tag; set { tag = value; } }
		};
	}
}

