﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class LOAIMONAN_BUS
    {
        public LoaiMonAn_DAO lmadao = new LoaiMonAn_DAO();
        public DataTable LayDSLoaiMonAn()
        {
            return lmadao.LayDSLoaiMonAn();

        }
        public bool ThemLoaiMonAn(string TenLoaiMA)
        {
            return lmadao.ThemLoaiMonAn(TenLoaiMA);
        }

    }
}
