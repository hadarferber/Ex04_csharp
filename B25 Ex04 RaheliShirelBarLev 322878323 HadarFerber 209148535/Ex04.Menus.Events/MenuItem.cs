using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_Title;
        private bool m_IsLeaf;
        public event Action WasChosen;
        private List<MenuItem> m_SubItems;
        
        public List<MenuItem> SubItems
        {
            get { return m_SubItems; }
        }

        public MenuItem(string i_Title, Action i_Function = null) //ctor
        {
            m_Title = i_Title;
            WasChosen = i_Function;
            m_SubItems = new List<MenuItem>();
            m_IsLeaf = (WasChosen != null); 
        }

        public bool IsLeaf
        {
            get { return m_IsLeaf; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public void AddSubItem(MenuItem item)
        {
            m_SubItems.Add(item);
        }


        private void OnWasChosen()
        {
            if (WasChosen != null)
            {
                WasChosen.Invoke();
            }
        }

        public void AMenuItemWasChosen()
        {
            OnWasChosen();
        }

    }
}
