using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNosql.Models
{
    public class Insurance
    {
        //Mã định danh
        public string insuranceId { get; set; }

        // loại bảo hiểm 
        public string insuranceType { get; set; }
        // số hợp đồng bắt đầu bằng HD
        public string policyId { set; get; }
        // tên nhà cung cấp bảo hiểm 
        public string provider { set; get; }

        public DateTime start_date { set; get; }

        public DateTime end_date { set; get; }

        // premium_frequency: Tần suất thanh toán phí bảo hiểm (hàng tháng, hàng quý, hàng năm).
        public string premium_frequency { set; get; }

        //Số tiền công dân cần chi trả mỗi lần yêu cầu bảo hiểm.
        public long co_payment_amount {  set; get; }

        //deductible_amount: Số tiền mà người tham gia bảo hiểm phải tự chi trả trước khi bảo hiểm bắt đầu chi trả.
        public long deductible_amount { set; get; }
        // ngày gia hạn hợp đồng
        public DateTime renewal_date
        {
            set;get;
        }
        //premium_amount: Số tiền bảo hiểm phải trả định kỳ.
        public long premium_amount { set; get; }


        /*
         * HAS_INSURANCE Công dân -> Bảo hiểm
         
           start_date: Ngày bắt đầu bảo hiểm.
           end_date: Ngày kết thúc bảo hiểm (nếu có).
           coverage_amount: Số tiền bảo hiểm hoặc mức độ bảo hiểm.
           
           status: Trạng thái của bảo hiểm (e.g., Active, Expired, Suspended).
          
         */
    }
}
