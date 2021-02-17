using AdminClientDAC;
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

        internal string AddCompany(string userID, CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            string result = dac.AddCompany(userID, vo);
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

        internal bool CompDetailAddProdList(List<ProductVO> addlist, string code)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.CompDetailAddProdList(addlist, code);
            dac.Dispose();
            return result;
        }

        internal bool SetUpdateList(List<CompanyDetailVO> updateList)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.SetUpdateList(updateList);
            dac.Dispose();
            return result;
        }

        internal bool UpdateCompInfo(CompanyDetailVO cpinfo)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.UpdateCompInfo(cpinfo);
            dac.Dispose();
            return result;
        }

        internal bool CompInfoDel(string compcode)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.CompInfoDel(compcode);
            dac.Dispose();
            return result;
        }
    }
}
