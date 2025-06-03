using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {

        private readonly string r_Title;
        private IMenuAction m_MethodToDo;
        private List<MenuItem> m_SubMenuItems;

        public string Title
        {
            get { return r_Title; }
        }

        public IMenuAction MethodToDo
        {
            get { return m_MethodToDo; }
        }

        public List<MenuItem> SubMenuItems
        {
            get { return m_SubMenuItems; }
        }

        public MenuItem(string i_Title, IMenuAction i_Action = null)
        {
            r_Title = i_Title;
            m_MethodToDo = i_Action;
            m_SubMenuItems = new List<MenuItem>();
        }

        public bool IsLeaf()
        {
           return m_MethodToDo != null;
        }

        public void AddSubMenuItem(MenuItem item)
        {
            SubMenuItems.Add(item);
        }

        public void Activate()
        {
            if (m_MethodToDo != null)
            {
                m_MethodToDo.ExecuteAction();
            }
        }
    }
}