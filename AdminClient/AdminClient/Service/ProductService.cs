using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
    class ProductService
    {
        internal List<ComboProductVO> GetComboBindingList()
        {
            ProductDAC dac = new ProductDAC();
            List<ComboProductVO> list = dac.GetComboBindingList();
            dac.Dispose();
            return list;
        }

        internal List<ProductVO> GetProdList(string cate, string unit, string state, string limit)
        {
            ProductDAC dac = new ProductDAC();
            List<ProductVO> list = dac.GetProdList(cate, unit, state, limit);
            dac.Dispose();
            return list;
        }

        internal bool UpdateProduct(ProductVO vo)
        {
            ProductDAC dac = new ProductDAC();
            bool result = dac.UpdateProduct(vo);
            dac.Dispose();
            return result;
        }

        internal bool DeleteProduct(string code)
        {
            ProductDAC dac = new ProductDAC();
            bool result = dac.DeleteProduct(code);
            dac.Dispose();
            return result;
        }

        internal string AddProduct(ProductVO vo)
        {
            ProductDAC dac = new ProductDAC();
            string code = dac.AddProduct(vo);
            dac.Dispose();
            return code;
        }
    }
}
