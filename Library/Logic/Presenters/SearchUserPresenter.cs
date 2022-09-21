using Library.Logic.Services;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Presenters
{
    public class SearchUserPresenter
    {
        SearchUserInterFace interFace; 
        public SearchUserPresenter(SearchUserInterFace i) {
            interFace = i;
           UpdateDGV();
        }
        public void UpdateDGV() {interFace.dgvDataSource = SearchUserServices.GetAllData(); }
        public void Search()
        {
            interFace.dgvDataSource = SearchUserServices.Search(interFace.Filters);
        }

        internal void Delete(int id)
        {
            SearchUserServices.Delete(id);
            UpdateDGV();
        }

        internal void DeleteAll()
        {
            SearchUserServices.DeleteAll();
            UpdateDGV();
        }
    } 
}
