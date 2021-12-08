using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi_020
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDReservasi, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi); //method proses input data
        [OperationContract]
        string editPemesanan(string IDReservasi, string NamaCustomer, string No_telepon);
        [OperationContract]
        string deletePemesanan(string IDReservasi);
        [OperationContract]
        List<CekLokasi> ReviewLokasi();//menampilkan data yang ada di database (select all) dengan menampilkan isi dari yang ada contract
        [OperationContract]
        List<DetailLokasi> DetailLokasi();//menampilkan detail lokasi
        [OperationContract]
        List<Pemesanan> Pemesanan();
    }

    [DataContract]
    public class CekLokasi //daftar lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; }//variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi //menampilkan detail lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiFull { get; set; }
        [DataMember]
        public int Kuota { get; set; }
    }

    [DataContract]
    public class Pemesanan //create
    {
        [DataMember]
        public string IDReservasi { get; set; }
        [DataMember]
        public string NamaCustomer { get; set; } //method
        [DataMember]
        public string NoTelepon { get; set; }
        [DataMember]
        public int JumlahPemesanan { get; set; }
        [DataMember]
        public string Lokasi { get; set; }
    }
}