
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WMS
{

using System;
    using System.Collections.Generic;
    
public partial class RefillOrder
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public RefillOrder()
    {

        this.RefillOrderDetails = new HashSet<RefillOrderDetail>();

    }


    public int OrderID { get; set; }

    public int OrderSource { get; set; }

    public int OrderDestination { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RefillOrderDetail> RefillOrderDetails { get; set; }

    public virtual Warehouse Warehouse { get; set; }

}

}
