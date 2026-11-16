using System.Reflection;
using System.Windows.Forms;

namespace QLBanVeMayBay
{
    // Tiện ích giao diện dùng chung cho các form
    public static class GiaoDien
    {
        // Bật vẽ đệm (double buffering) cho lưới: lưới nhiều dòng sẽ hiện, cuộn và đổi kích thước nhanh, không bị giật.
        // DoubleBuffered là thuộc tính protected nên không chỉnh được trong Designer, phải bật bằng reflection.
        public static void LuoiMuot(DataGridView luoi)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                .SetValue(luoi, true, null);
        }
    }
}
