﻿using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class CompanyService
    {
        internal List<ComboCompVO> GetComboBindingList()
        {
            CompanyDAC dac = new CompanyDAC();
            List<ComboCompVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal List<CompanyVO> GetCompanyList(string limit, string auto, string state, string type)
        {
            CompanyDAC dac = new CompanyDAC();
            List<CompanyVO> list = dac.GetCompanyList(limit, auto, state, type);
            dac.Dispose();
            return list;
        }

        internal List<CompanyPopUpVO> GetCompanyTypeList_Popup()
        {
            CompanyDAC dac = new CompanyDAC();
            List<CompanyPopUpVO> list = dac.GetCompanyTypeList_Popup();
            dac.Dispose();
            return list;
        }

        internal bool AddCompany(string userID, CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.AddCompany(userID, vo);
            dac.Dispose();
            return result;
        }

        internal bool UpdateCompany(string userID, CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.UpdateCompany(userID, vo);
            dac.Dispose();
            return result;
        }

        internal List<CompanyDetailVO> GetDetailInfo(string code)
        {
            CompanyDAC dac = new CompanyDAC();
            List<CompanyDetailVO> list = dac.GetDetailInfo(code);
            dac.Dispose();
            return list;
        }
    }
}
