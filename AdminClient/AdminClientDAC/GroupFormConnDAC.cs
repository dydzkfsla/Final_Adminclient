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
    public class GroupFormConnDAC: IDisposable
    {
        SqlConnection conn;
        LoggingUtility Logging;

        public GroupFormConnDAC()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Connstring.conn;
            conn.Open();
            Logging = new LoggingUtility("GroupFormConnDACInFo", "GroupFormConnDACError", Level.All, 30);
            Logging.InfoFolder = "C:\\FP\\Log\\GroupFormConnDAC\\Info";
            Logging.ErrorFolder = "C:\\FP\\Log\\GroupFormConnDAC\\Error";
        }


        #region select

        /// <summary>
        /// 모든 정보 조회
        /// </summary>
        /// <returns></returns>
        public List<GroupFormConnVO> GetAllGroupFormConnVO()
        {
            try {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "select Group_No, Form_Name from Group_Form_Conn"
                };

                using(SqlDataReader reader = sql.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<GroupFormConnVO>(reader);
                }
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 conn Form 정보 Select중 오류" + err.Message, err);
                return null;
            }
        }
        #endregion

        #region insert
        public bool InsertGroupFormConn(int GropNo, string FromName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "insert into Group_Form_Conn(Group_No, Form_Name, Fst_Writer, Fst_WriteDate) values(@Group_No, @Form_Name, @Fst_Writer, getdate())"
                };

                sql.Parameters.AddWithValue("@Group_No", GropNo);
                sql.Parameters.AddWithValue("@Form_Name", FromName);
                sql.Parameters.AddWithValue("@Fst_Writer", Global.employees.Emp_Code);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 그룹 conn Form 입력중 수정 | {GropNo} | {FromName}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 conn Form 입력중 오류" + err.Message, err);
                return false;
            }
        }
        #endregion

        #region delete
        public bool DeleteGroupFormConn(int GropNo, string FromName)
        {
            try
            {
                SqlCommand sql = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Delete From Group_Form_Conn where Group_No = @Group_No and Form_Name = @Form_Name"
                };

                sql.Parameters.AddWithValue("@Group_No", GropNo);
                sql.Parameters.AddWithValue("@Form_Name", FromName);

                bool Execut = sql.ExecuteNonQuery() > 0 ? true : false;

                if (Execut)
                {
                    Logging.WriteInfo($"실행자:{Global.employees.Emp_Name} 그룹 conn Form 삭제 | {GropNo} | {FromName}");
                }
                return Execut;
            }
            catch (Exception err)
            {
                Logging.WriteError($"실행자:{Global.employees.Emp_Name} 그룹 conn Form 삭제중 오류" + err.Message, err);
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
