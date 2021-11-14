using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Logic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        [DisplayName("Номер для поиска")]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
    }
}
