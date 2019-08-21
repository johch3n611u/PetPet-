//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetPet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class PetVariety
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetVariety()
        {
            this.Pet = new HashSet<Pet>();
        }
        [DisplayName("品種編號")]
        [Required]
        public int PetVariety_no { get; set; }
        [DisplayName("類別編號")]
        [Required]
        public int PetType_no { get; set; }
        [DisplayName("品種名稱")]
        [Required]
        public string Variety_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pet> Pet { get; set; }
        public virtual PetType PetType { get; set; }
    }
}
