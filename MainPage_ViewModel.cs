using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CollectionView
{
    public class MainPage_ViewModel
    {

        public MainPage_ViewModel()
        {
            prp_StockCards = new ObservableCollection<Models.StockCard>();

            for (int i = 0; i < 200; i++)
            {
                Models.StockCard tmp_StockCard = new Models.StockCard();
                prp_StockCards.Add(tmp_StockCard);
            }
        }

        private ObservableCollection<Models.StockCard> prp_StockCards;
        public ObservableCollection<Models.StockCard> StockCards
        {
            get
            {
                return prp_StockCards;
            }
            set
            {
                prp_StockCards = value;
            }
        }

    }
}
