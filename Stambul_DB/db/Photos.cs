//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stambul_DB.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photos
    {
        public int id_Photos { get; set; }
        public Nullable<int> id_City_Maps { get; set; }
        public Nullable<int> id_Regional_Maps { get; set; }
        public Nullable<int> id_Special_Maps { get; set; }
        public Nullable<int> id_Pervetitich_Maps { get; set; }
        public Nullable<int> id_Satellite_Maps { get; set; }
        public Nullable<int> id_Major_Roads { get; set; }
        public Nullable<int> Id_Spaces_of_Everyday_Life { get; set; }
        public Nullable<int> id_Transportation { get; set; }
        public Nullable<int> Year_Photos { get; set; }
        public Nullable<int> Count_Photos { get; set; }
        public byte[] Image_Photos { get; set; }
    
        public virtual City_Maps City_Maps { get; set; }
        public virtual Major_Roads Major_Roads { get; set; }
        public virtual Pervetitich_Maps Pervetitich_Maps { get; set; }
        public virtual Regional_Maps Regional_Maps { get; set; }
        public virtual Satellite_Maps Satellite_Maps { get; set; }
        public virtual Spaces_of_Everyday_Life Spaces_of_Everyday_Life { get; set; }
        public virtual Special_Maps Special_Maps { get; set; }
        public virtual Transportation Transportation { get; set; }
    }
}
