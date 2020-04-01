﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model;
using DB.IDal;
using System.Data.SqlClient;
using System.Data;

namespace DB.Dal
{
    /// <summary>
    /// 审批流权限流程表：AuditAccess
    /// </summary>
    public class D_AuditAccess : SqlBase, I_AuditAccess
    {
        //数据库表名
        private string TableName { get; set; } = "AuditAccess";

        //删除多个（查ID）
        public int Delete(List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"delete from {TableName} where ID = @ID", conn);
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);
                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (int m in ID)
                    {
                        cmd.Parameters["@ID"].Value = m;
                        if (cmd.ExecuteNonQuery() > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (ID.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //删除单个（查ID）
        public int Delete(int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"delete from {TableName} where ID = {ID}", conn);
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //插入多个
        public int Insert(ref List<M_AuditAccess> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,AuditFlow_ID,LevelHierarchy) values (@User_ID,@AuditFlow_ID,@LevelHierarchy);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AuditFlow_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LevelHierarchy", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;

                try
                {
                    conn.Open();
                    foreach (M_AuditAccess m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@AuditFlow_ID"].Value = m.AuditFlow_ID;
                        cmd.Parameters["@LevelHierarchy"].Value = m.LevelHierarchy;
                        decimal d = (decimal)cmd.ExecuteScalar();
                        m.ID = (int)d;
                        if (m.ID > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (Obj.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //插入单个
        public int Insert(ref M_AuditAccess Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,AuditFlow_ID,LevelHierarchy) values (@User_ID,@AuditFlow_ID,@LevelHierarchy);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AuditFlow_ID", SqlDbType.Int);
                par.Value = Obj.AuditFlow_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LevelHierarchy", SqlDbType.Int);
                par.Value = Obj.LevelHierarchy;
                cmd.Parameters.Add(par);

                try
                {
                    conn.Open();
                    decimal d = (decimal)cmd.ExecuteScalar();
                    Obj.ID = (int)d;
                    if (Obj.ID > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //更新多个
        public int Update(List<M_AuditAccess> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, AuditFlow_ID = @AuditFlow_ID, LevelHierarchy = @LevelHierarchy where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AuditFlow_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LevelHierarchy", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditAccess m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@AuditFlow_ID"].Value = m.AuditFlow_ID;
                        cmd.Parameters["@LevelHierarchy"].Value = m.LevelHierarchy;
                        cmd.Parameters["@ID"].Value = m.ID;
                        if (cmd.ExecuteNonQuery() > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (Obj.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //更新单个（查ID）
        public int Update(M_AuditAccess Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, AuditFlow_ID = @AuditFlow_ID, LevelHierarchy = @LevelHierarchy where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AuditFlow_ID", SqlDbType.Int);
                par.Value = Obj.AuditFlow_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LevelHierarchy", SqlDbType.Int);
                par.Value = Obj.LevelHierarchy;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                par.Value = Obj.ID;
                cmd.Parameters.Add(par);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //查询多个（查ID）
        public int Select(ref List<M_AuditAccess> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,AuditFlow_ID,LevelHierarchy from {TableName} where ID = @ID", conn);
                SqlDataReader sdr;
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (int i in ID)
                    {
                        cmd.Parameters["@ID"].Value = i;
                        sdr = cmd.ExecuteReader();
                        foreach (M_AuditAccess m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.AuditFlow_ID = (int)sdr["AuditFlow_ID"];
                                m.LevelHierarchy = (int)sdr["LevelHierarchy"];
                                m.User_ID = (int)sdr["User_ID"];
                                tmpOut++;
                            }
                        }
                        sdr.Close();  
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (ID.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //查询单个（查ID）
        public int Select(ref M_AuditAccess Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,AuditFlow_ID,LevelHierarchy from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.AuditFlow_ID = (int)sdr["AuditFlow_ID"];
                        Obj.LevelHierarchy = (int)sdr["LevelHierarchy"];
                        Obj.User_ID = (int)sdr["User_ID"];
                        return 1;
                    }
                    return -1;
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
    }//
}//