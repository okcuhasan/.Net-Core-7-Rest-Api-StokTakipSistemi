﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.ENTITIES.DataTransferObjects
{
    public class MusteriDTO
    {
        public string MusteriAdi { get; set; }
        public string? MailAdresi { get; set; }
        public string? TelefonNumarasi { get; set; }
        public string? Adres { get; set; }
    }
}
