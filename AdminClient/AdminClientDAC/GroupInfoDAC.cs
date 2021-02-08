using AdminClientVO;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClientDAC
{
    public class GroupInfoDAC : IDisposable
    {
        SqlConnection conn;
        LoggingUtility Logging;

        public GroupInfoDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
            Logging = new LoggingUtility("GroupInfoDACInFo", "GroupInfoDACError", Level.All, 30);
            Logging.InfoFolder = "C:\\FP\\Log\\GroupInfoDAC\\Info";
            Logging.ErrorFolder = "C:\\FP\\Log\\GroupInfoDAC\\Error";
        }


        #region select
        /// <summary>
        /// 모든 vo가져옴
        /// </summary>
        /// <returns></returns>
        public List<GroupInfoVO> AllGroupInfoVO()
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Grp_No, Grp_Name from Group_Info"
                };

                using (SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<GroupInfoVO>(reader);
                }
            }
            catch(Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #region insert
        public bool InserGroupInfo(int GroupNo, string GroupName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Group_Info(Grp_No, Grp_Name, Fst_Writer) values (@Grp_No, @Grp_Name, @Fst_Writer)"
                };
                sql.Parameters.AddWithValue("@Grp_No", GroupNo);
                sql.Parameters.AddWithValue("@Grp_Name", GroupName);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 그룹 정보 입력 | {GroupNo} : {GroupName}");
                }

                return Execut;
            }
            catch(Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 입력중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region delete
        public bool DeleteGroupInfo(int GropNo)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "delete from Group_Info where Grp_No = @Grp_No"
                };
                sql.Parameters.AddWithValue("@Grp_No", GropNo);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 그룹 삭제 | {GropNo}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 삭제중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region Update
        public bool UpdateGroupInfo(int GropNo, string GropName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = @"update Group_Info set Grp_Name = @Grp_Name,
                                    Lst_Writer = @Lst_Writer,
                                    Lst_WriteDate = getdate()
                                    where Grp_No = @Grp_No"
                };
                sql.Parameters.AddWithValue("@Grp_No", GropNo);
                sql.Parameters.AddWithValue("@Grp_Name", GropName);
                sql.Parameters.AddWithValue("@Lst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 그룹 수정 | {GropNo} | {GropName}");
                }

                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 수정중 오류" + err.Message, err);
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Logging.CloseRoller();
            conn.Dispose();
        }
    }
}
