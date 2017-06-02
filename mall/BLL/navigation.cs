using System;
using System.Data;
using System.Collections.Generic;
using Common;

namespace BLL
{
	/// <summary>
	/// ϵͳ�����˵�
	/// </summary>
	public partial class navigation
	{
        private readonly Model.siteconfig siteConfig = new BLL.siteconfig().loadConfig(); //���վ��������Ϣ
		private readonly DAL.navigation dal;
		public navigation()
		{
            dal = new DAL.navigation(siteConfig.sysdatabaseprefix);
        }

		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

        /// <summary>
        /// ��ѯ�����Ƿ����
        /// </summary>
        public bool Exists(string name)
        {
            return dal.Exists(name);
        }

        /// <summary>
        /// �������ϵͳĬ�ϵ���
        /// </summary>
        /// <param name="parent_name">����������</param>
        /// <param name="nav_name">��������</param>
        /// <param name="title">��������</param>
        /// <param name="link_url">���ӵ�ַ</param>
        /// <param name="sort_id">��������</param>
        /// <param name="channel_id">����Ƶ��ID</param>
        /// <param name="action_type">����Ȩ����Ӣ�Ķ��ŷָ���</param>
        /// <returns>int</returns>
        public int Add(string parent_name, string nav_name, string title, string link_url, int sort_id, int channel_id, string action_type)
        {
            int parent_id = dal.GetNavId(parent_name);
            return dal.Add(parent_id, nav_name, title, link_url, sort_id, channel_id, action_type);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Model.navigation model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// �޸�һ������
        /// </summary>
        public bool UpdateField(int id, string strValue)
        {
            return dal.UpdateField(id, strValue);
        }

        /// <summary>
        /// �޸�һ������
        /// </summary>
        public bool UpdateField(string name, string strValue)
        {
            return dal.UpdateField(name, strValue);
        }

        /// <summary>
        /// �޸ĵ������ƺͱ���
        /// </summary>
        /// <param name="old_name">������</param>
        /// <param name="new_name">������</param>
        /// <param name="title">����</param>
        /// <returns></returns>
        public bool Update(string old_name, string new_name, string title)
        {
            return dal.Update(old_name, new_name, title);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Model.navigation model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			return dal.Delete(id);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.navigation GetModel(string name)
        {
            return dal.GetModel(name);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Model.navigation GetModel(int id)
        {
            return dal.GetModel(id);
        }

        /// <summary>
        /// ȡ����������б�
        /// </summary>
        /// <param name="parent_id">��ID</param>
        /// <param name="nav_type">�������</param>
        /// <returns>DataTable</returns>
        public DataTable GetList(int parent_id, string nav_type)
        {
            return dal.GetList(parent_id, nav_type);
        }

		#endregion

        #region ��չ����================================
        /// <summary>
        /// ���ݵ��������Ʋ�ѯ��ID
        /// </summary>
        public int GetNavId(string nav_name)
        {
            return dal.GetNavId(nav_name);
        }

        /// <summary>
        /// ȡ��ָ������µ��б�
        /// </summary>
        /// <param name="parent_id">��ID</param>
        /// <param name="nav_type">�������</param>
        /// <returns>DataTable</returns>
        public DataTable GetChildList(int parent_id, string nav_type)
        {
            return dal.GetChildList(parent_id, nav_type);
        }

        /// <summary>
        /// ȡ����������б�(û������ã�ֻ������)
        /// </summary>
        /// <param name="parent_id">��ID��0Ϊ�������</param>
        /// <param name="nav_type">�������</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataList(int parent_id, string nav_type)
        {
            return dal.GetDataList(parent_id, nav_type);
        }
        #endregion
    }
}
