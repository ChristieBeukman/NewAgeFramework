using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewAgeFramework.Model;
using NewAgeFramework.Model.DataModel;

namespace NewAgeFramework.ViewModel
{
    public class LengthCostingViewModel : BaseViewModel
    {
        dbNewEntities ctx = new dbNewEntities(); // Data model Entities datacontext

        #region Properties

        #region Private Properties

        private List<LengthMaterialModel> _JoinedLengthModel;
        private LengthMaterialModel _SelectedLenghMaterial;
        #endregion

        #region Public Properties

        public List<LengthMaterialModel> JoinedLengthModel
        {
            get
            {
                return _JoinedLengthModel;
            }

            set
            {
                _JoinedLengthModel = value;
                NotifyPropertyChanged();
            }
        }

        public LengthMaterialModel SelectedLenghMaterial
        {
            get
            {
                return _SelectedLenghMaterial;
            }

            set
            {
                _SelectedLenghMaterial = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #endregion

        #region Constructor

        public LengthCostingViewModel()
        {
            GetLengthMaterials();
        }



        #endregion

        #region Select

        /// <summary>
        /// Select all lenght data with a left join to view mateerial name and descriptopm
        /// </summary>
        private void GetLengthMaterials()
        {
            var Query = (from l in ctx.tblLengthCosts
                         join m in ctx.tblMaterials
                         on l.MaterialID equals m.MaterialID
                         select new LengthMaterialModel
                         {
                             MaterialID = l.MaterialID,
                             Name = m.Name,
                             Description = m.Description,
                             NoPieces = l.NoPieces,
                             LengthPerPiece = l.LengthPerPiece,
                             TotalCostPieces = l.TotalCostPieces,
                             TotalLength = l.TotalLength,
                             PricePerMeter = l.PricePerMeter
                         }).ToList();
            this.JoinedLengthModel = Query;
        }

        #endregion


    }
}
