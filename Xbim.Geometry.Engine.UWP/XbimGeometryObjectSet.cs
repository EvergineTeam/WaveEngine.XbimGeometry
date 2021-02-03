
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using Xbim.Common.Geometry;
using Xbim.Ifc4;
using Xbim.Ifc4.Interfaces;

namespace Xbim
{
    namespace Geometry
    {
        //static bool PerformBoolean(BRepAlgoAPI_BooleanOperation& boolOp);
        public class XbimGeometryObjectSet : XbimSetObject, IXbimGeometryObjectSet
        {
            private List<IXbimGeometryObject> geometryObjects;
            private static XbimGeometryObjectSet empty = new XbimGeometryObjectSet();

            private static bool ParseGeometry(IEnumerable<IXbimGeometryObject> geomObjects, REF_TopTools_ListOfShape toBeCut, REF_Bnd_Array1OfBox aBoxes, REF_TopoDS_Shell facesToIgnore, double tolerance)
            {
                throw new NotImplementedException();
            }

            private void InstanceCleanup()
            {
                geometryObjects = null;
            }

            private static TopoDS_Compound CreateCompound(IEnumerable<IXbimGeometryObject> geomObjects)
            {
                throw new NotImplementedException();
            }

            //----------

            public static IXbimGeometryObjectSet Empty { get { return empty; } }

            public static IXbimGeometryObjectSet PerformBoolean(BOPAlgo_Operation bop, IEnumerable<IXbimGeometryObject> geomObjects, IXbimSolidSet solids, double tolerance, ILogger logger)
            {
                throw new NotImplementedException();
            }

            public static IXbimGeometryObjectSet PerformBoolean(BOPAlgo_Operation bop, IXbimGeometryObject geomObject, IXbimSolidSet solids, double tolerance, ILogger logger)
            {
                throw new NotImplementedException();
            }

            public XbimGeometryObjectSet()
            {
                throw new NotImplementedException();
            }

            public XbimGeometryObjectSet(IEnumerable<IXbimGeometryObject> objects)
            {
                throw new NotImplementedException();
            }

            public XbimGeometryObjectSet(int size)
            {
                geometryObjects = new List<IXbimGeometryObject>(size);
            }

            #region destructors

            public void Dispose()
            {
                InstanceCleanup();
            }

            //~XbimGeometryObjectSet(){ InstanceCleanup(); }
            //!XbimGeometryObjectSet(){ InstanceCleanup(); }

            #endregion

            #region IXbimGeometryObjectSet Interface
            public virtual bool IsValid { get { return geometryObjects != null && this != XbimGeometryObjectSet.Empty; } }
            public virtual bool IsSet { get { return true; } }
            public virtual IXbimGeometryObject First { get { throw new NotImplementedException(); } }
            public override int Count { get { throw new NotImplementedException(); } }

            public override IXbimGeometryObject Trim() { if (Count == 1) return First; else if (Count == 0) return null; else return this; }

            public virtual XbimGeometryObjectType GeometryType { get { return XbimGeometryObjectType.XbimGeometryObjectSetType; } }

            public virtual IEnumerator<IXbimGeometryObject> GetEnumerator()
            {
                throw new NotImplementedException();
            }
            //public virtual System::Collections::IEnumerator^ GetEnumerator2() = System::Collections::IEnumerable::GetEnumerator{ return GetEnumerator(); }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }

            public virtual XbimRect3D BoundingBox
            {
                get { throw new NotImplementedException(); }
            }

            public virtual IXbimGeometryObject Transform(XbimMatrix3D matrix3D)
            {
                throw new NotImplementedException();
            }
            public virtual IXbimGeometryObject TransformShallow(XbimMatrix3D matrix3D)
            {
                throw new NotImplementedException();
            }
            public virtual IXbimSolidSet Solids
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
            public virtual IXbimShellSet Shells { get { throw new NotImplementedException(); } }

            public virtual IXbimFaceSet Faces
            {
                get { throw new NotImplementedException(); }
            }
            public virtual IXbimEdgeSet Edges
            {
                get { throw new NotImplementedException(); }
            }
            public virtual IXbimVertexSet Vertices { get { throw new NotImplementedException(); } }
            public virtual IXbimGeometryObjectSet Cut(IXbimSolidSet solids, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual IXbimGeometryObjectSet Cut(IXbimSolid solid, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual IXbimGeometryObjectSet Union(IXbimSolidSet solids, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual IXbimGeometryObjectSet Union(IXbimSolid solid, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual string ToBRep
            {
                get
                { throw new NotImplementedException(); }
            }
            public virtual IXbimGeometryObjectSet Intersection(IXbimSolidSet solids, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual IXbimGeometryObjectSet Intersection(IXbimSolid solid, double tolerance, ILogger logger)
            { throw new NotImplementedException(); }
            public virtual bool Sew()
            { throw new NotImplementedException(); }
            #endregion
            public virtual void Add(IXbimGeometryObject geomObj) { geometryObjects.Add(geomObj); }

            // Inherited via XbimSetObject
            public override IXbimGeometryObject Transformed(IIfcCartesianTransformationOperator transformation)
            { throw new NotImplementedException(); }
            public override IXbimGeometryObject Moved(IIfcPlacement placement)
            { throw new NotImplementedException(); }
            public override IXbimGeometryObject Moved(IIfcObjectPlacement objectPlacement, ILogger logger)
            { throw new NotImplementedException(); }

            // Inherited via XbimSetObject
            public override void Mesh(IXbimMeshReceiver mesh, double precision, double deflection, double angle)
            { throw new NotImplementedException(); }

        };
    }
}
