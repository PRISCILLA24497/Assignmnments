//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineMovieTicketBooking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Screennew
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Screennew()
        {
            this.Shownew = new HashSet<Shownew>();
        }
    
        public int Sid { get; set; }
        public string screenname { get; set; }
        public Nullable<int> theatreid { get; set; }
        public Nullable<int> showid { get; set; }
        public Nullable<int> rows { get; set; }
        public Nullable<int> columns { get; set; }
    
        public virtual Theatrenew Theatrenew { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shownew> Shownew { get; set; }
    }
}