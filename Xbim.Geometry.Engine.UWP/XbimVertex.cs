using Microsoft.Extensions.Logging;
using System;
using Xbim.Common.Geometry;
using Xbim.Geometry;
using Xbim.Geometry.Engine.UWP;
using Xbim.Geometry.Engine.UWP.OCCbindings;
using Xbim.Ifc4;
using Xbim.Ifc4.Interfaces;

namespace Xbim
{
    namespace Geometry
    {
        public unsafe class XbimVertex : IXbimVertex, XbimOccShape
        {
            protected System.IntPtr ptrContainer;

            protected TopoDS_Vertex* pVertex
            {
                get { return (TopoDS_Vertex*)ptrContainer.ToPointer(); }
                set { ptrContainer = new System.IntPtr(value); }
            }
            protected void InstanceCleanup()
            {
                throw new NotImplementedException();
            }


            #region Equality Overrides
            public override bool Equals(Object v)
            {
                throw new NotImplementedException();
            }

            public override int GetHashCode()
            {
                throw new NotImplementedException();
            }


            public static bool operator ==(XbimVertex left, XbimVertex right)
            {
                throw new NotImplementedException();
            }

            public static bool operator !=(XbimVertex left, XbimVertex right)
            {
                throw new NotImplementedException();
            }

            public virtual bool Equals(IXbimVertex v)
            {
                throw new NotImplementedException();
            }
            #endregion



            #region IXbimVertexInterfaces
            public override XbimGeometryObjectType GeometryType
            {
                get { return XbimGeometryObjectType.XbimVertexType; }
            }

            public override bool IsValid
            {
                get { return pVertex != null; }
            }

            public override XbimRect3D BoundingBox
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public XbimPoint3D VertexGeometry
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public override IXbimGeometryObject Transform(XbimMatrix3D matrix3D)
            {
                throw new NotImplementedException();
            }

            public override IXbimGeometryObject TransformShallow(XbimMatrix3D matrix3D)
            {
                throw new NotImplementedException();
            }
            #endregion



            #region Constructors
            ///Constructs vertex with no geometric location
            public XbimVertex()
            {
                throw new NotImplementedException();
            }

            public XbimVertex(XbimPoint3D point3D, double precision)
            {
                throw new NotImplementedException();
            }

            public XbimVertex(XbimPoint3DWithTolerance^ point3D)
            {
                throw new NotImplementedException();
            }

            public XbimVertex(CONSTREF_TopoDS_Vertex& occVertex)
            {
                throw new NotImplementedException();
            }

            public XbimVertex(CONSTREF_TopoDS_Vertex occVertex, Object tag)
            {
                throw new NotImplementedException();
            }

            public XbimVertex(IXbimVertex vertex, double precision)
            {
            }

            public XbimVertex(IIfcCartesianPoint vertex)
            {
                throw new NotImplementedException();
            }

            public XbimVertex(double x, double y, double z, double precision)
            {
                throw new NotImplementedException();
            }

#if USE_CARVE_CSG
			public XbimVertex(vertex_t* v, double precision)
			{
				throw new NotImplementedException();
			}
#endif // USE_CARVE_CSG

            #endregion

            #region Destructors

            public ~XbimVertex() { InstanceCleanup(); }
            public !XbimVertex() { InstanceCleanup(); }

            #endregion


            #region Operators

            public operator const TopoDS_Vertex& () { return *pVertex; }

            public override operator const TopoDS_Shape& () override { return *pVertex; }

            public double Tolerance { get { return IsValid ? BRep_Tool::Tolerance(*pVertex) : 0; } }
    #endregion

    // Inherited via XbimOccShape
            public override XbimGeometryObject Transformed(IIfcCartesianTransformationOperator transformation)
            {
                throw new NotImplementedException();
            }


            // Inherited via XbimOccShape
            public override XbimGeometryObject Moved(IIfcPlacement placement)
            {
                throw new NotImplementedException();
            }

            public virtual void Move(TopLoc_Location loc)
            {
                throw new NotImplementedException();
            }

            // Inherited via XbimOccShape
            public override XbimGeometryObject Moved(IIfcObjectPlacement objectPlacement, ILogger logger)
            {
                throw new NotImplementedException();
            }


            // Inherited via XbimOccShape
            public override void Mesh(IXbimMeshReceiver mesh, double precision, double deflection, double angle)
            {
                throw new NotImplementedException();
            }

}
	}
}
