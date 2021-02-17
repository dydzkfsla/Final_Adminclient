using AdminClientDAC;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient.Service
{
	public class ProcessService : IDisposable
	{
		ProcessDAC dac;
		public ProcessService()
		{
			dac = new ProcessDAC();
		}
		public void Dispose()
		{
			dac.Dispose();
		}
		public List<ProcessVO> GetPcsList(string limit, string state)
		{
			return dac.GetPcsList(limit, state);
		}
		public List<ProcessDetailVO> GetPDList(string code)
		{
			return dac.GetPDList(code);
		}
		public List<ProcessVO> RefreshPcsList()
		{
			return dac.RefreshPcsList();
		}
		public bool AddProcess(string userID, ProcessVO vo)
		{
			return dac.AddProcess(userID, vo);
		}
		public bool AddProcessDetil(string userID, ProcessDetailVO vo)
		{
			return dac.AddProcessDetil(userID, vo);
		}
		public bool UpdateProcess(string userID, ProcessVO vo)
		{
			return dac.UpdateProcess(userID, vo);
		}
		public bool UpdateProcessDetail(string userID, ProcessDetailVO vo)
		{
			return dac.UpdateProcessDetail(userID, vo);
		}
		public bool DeleteProcess(string userID, string code)
		{
			return dac.DeleteProcess(userID, code);
		}
		public bool DeleteProcessDetail(string userID, string code)
		{
			return dac.DeleteProcessDetail(userID, code);
		}
	}
}
