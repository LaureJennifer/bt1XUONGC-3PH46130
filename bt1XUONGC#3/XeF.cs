using bt1XUONGC_3.DomainClass;
using bt1XUONGC_3.Services;
using System.Web;

namespace bt1XUONGC_3
{
    public partial class XeF : Form
    {
        XeMayServices _xeMayservice = new XeMayServices();
        Guid? _idCellClick = null;
        List<XeMay> _listObj = new();
        
        public XeF()
        {
            InitializeComponent();
        }
        private void XeF_Load(object sender, EventArgs e)
        {
            LoadGrid(string.Empty);
            LoadCombobox();
        }
        private void LoadCombobox()
        {
            for (int i = 1; i <= 100; i++)
            {
                soLuongText.Items.Add(i.ToString());
            }
        }

        private void LoadGrid(string textSearch)
        {
            xeGrid.Rows.Clear();
            xeGrid.ColumnCount = 5;
            xeGrid.Columns[0].Name = "STT";
            xeGrid.Columns[1].Name = "Tên Xe";
            xeGrid.Columns[2].Name = "Mô tả";
            xeGrid.Columns[3].Name = "Số lượng";
            xeGrid.Columns[4].Name = "Loại xe";

            _listObj = _xeMayservice.GetAll(textSearch);
            foreach (var item in _listObj)
            {
                xeGrid.Rows.Add((_listObj.IndexOf(item) + 1), item.Ten, item.Mota, item.SoLuong, (item.IdLxm == null ? "Xe nhái" : _xeMayservice.GetloaiXe().Where(x=>x.Id==item.IdLxm).Select(x=>x.Ten).First()));

            }

        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if (!_xeMayservice.CheckGiaNhap(giaNhapText.Text))
            {
                MessageBox.Show("Sai định dạng giá nhập . Hãy nhập lại.");

            }
            else
            {
                if (!_xeMayservice.CheckvalueGia(Convert.ToDecimal(giaNhapText.Text)))
                {
                    MessageBox.Show("Gía nhập phải lớn hơn 0.");
                }
                else
                {

                    var XeAdd = new XeMay()
                    {
                        Ten = tenText.Text,
                        Mota = motaText.Text,
                        GiaNhap = Convert.ToDecimal(giaNhapText.Text),
                        SoLuong = Convert.ToInt32(soLuongText.Text),
                        IdLxm = CheckLoaiXe(tenText.Text)
                        

                    };

                    var resultAdd = _xeMayservice.Add(XeAdd);
                    if (resultAdd == true)
                    {
                        MessageBox.Show("Add succeeded.");
                        LoadGrid(string.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Add Failed");
                    }
                }

            }

        }
        private Guid? CheckLoaiXe(string Loai)
        {
            var obj = _xeMayservice.GetloaiXe().FirstOrDefault(x => x.Ten.ToLower().Contains(Loai));
            if (obj == null)
            {
                return null;
            }
            return obj.Id;
        }
        

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (_idCellClick != null)
            {
                var resultDele = _xeMayservice.Delete((Guid)_idCellClick);
                if (resultDele == true)
                {
                    MessageBox.Show("Delete Succeeded");
                    LoadGrid(string.Empty);
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }

            }
        }

        private void hienThiBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(timKiemText.Text))
            {
                MessageBox.Show("Cần nhập tên xe để tìm.");
            }
            if (_xeMayservice.CheckTenXe(timKiemText.Text))
            {
                LoadGrid(timKiemText.Text);
            }
            else
            {
                MessageBox.Show("Không có xe này.");
            }

        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            tenText.Clear();
            motaText.Clear();
            giaNhapText.Clear();
            soLuongText.Text = "5";
        }


        private void xeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var objCellClick = _listObj[index];
            _idCellClick = objCellClick.Id;
        }

        
    }
}