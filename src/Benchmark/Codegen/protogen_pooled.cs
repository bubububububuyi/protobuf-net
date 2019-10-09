﻿//#if NEW_API
//// This file was generated by a tool; you should avoid making direct changes.
//// Consider using 'partial classes' to extend these types
//// Input: my.proto

//#pragma warning disable CS1591, CS0612, CS3021, IDE1006
//using ProtoBuf.Collections;
//using System;

//namespace protogen.pooled
//{

//    [global::ProtoBuf.ProtoContract()]
//    public partial class Database : global::ProtoBuf.IExtensible, IDisposable
//    {
//        void IDisposable.Dispose()
//        {
//            PooledList.Dispose(ref _orders, true);
//        }

//        private global::ProtoBuf.IExtension __pbn__extensionData;
//        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
//            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

//        [global::ProtoBuf.ProtoMember(1)]
//        public PooledList<Order> Orders => PooledList.Create(ref _orders);
//        public bool ShouldSerializeOrders() => _orders.ShouldSerialize();
//        private PooledList<Order> _orders;
//    }

//    [global::ProtoBuf.ProtoContract()]
//    public partial class Order : global::ProtoBuf.IExtensible, IDisposable
//    {
//        void IDisposable.Dispose()
//        {
//            PooledList.Dispose(ref _lines, true);
//        }

//        private global::ProtoBuf.IExtension __pbn__extensionData;
//        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
//            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

//        [global::ProtoBuf.ProtoMember(1)]
//        public int OrderID { get; set; }

//        [global::ProtoBuf.ProtoMember(2)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string CustomerID { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(3)]
//        public int EmployeeID { get; set; }

//        [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
//        public global::System.DateTime? OrderDate { get; set; }

//        [global::ProtoBuf.ProtoMember(5, DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
//        public global::System.DateTime? RequiredDate { get; set; }

//        [global::ProtoBuf.ProtoMember(6, DataFormat = global::ProtoBuf.DataFormat.WellKnown)]
//        public global::System.DateTime? ShippedDate { get; set; }

//        [global::ProtoBuf.ProtoMember(7)]
//        public int ShipVia { get; set; }

//        [global::ProtoBuf.ProtoMember(8)]
//        public double Freight { get; set; }

//        [global::ProtoBuf.ProtoMember(9)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipName { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(10)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipAddress { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(11)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipCity { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(12)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipRegion { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(13)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipPostalCode { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(14)]
//        [global::System.ComponentModel.DefaultValue("")]
//        public string ShipCountry { get; set; } = "";

//        [global::ProtoBuf.ProtoMember(15)]
//        public PooledList<OrderLine> Lines => PooledList.Create(ref _lines);
//        public bool ShouldSerializeLines() => _lines.ShouldSerialize();
//        private PooledList<OrderLine> _lines;

//    }

//    [global::ProtoBuf.ProtoContract()]
//    public partial class OrderLine : global::ProtoBuf.IExtensible, IDisposable
//    {
//        void IDisposable.Dispose() { }

//        private global::ProtoBuf.IExtension __pbn__extensionData;
//        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
//            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

//        [global::ProtoBuf.ProtoMember(1)]
//        public int OrderID { get; set; }

//        [global::ProtoBuf.ProtoMember(2)]
//        public int ProductID { get; set; }

//        [global::ProtoBuf.ProtoMember(3)]
//        public double UnitPrice { get; set; }

//        [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
//        public int Quantity { get; set; }

//        [global::ProtoBuf.ProtoMember(5)]
//        public float Discount { get; set; }

//    }

//}

//#pragma warning restore CS1591, CS0612, CS3021, IDE1006

//#endif