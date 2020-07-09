using DevExpress.Mvvm.DataAnnotations;
using QLCAFE_WPF.Model;
using QLCAFE_WPF.View.Localization;

namespace QLCAFE_WPF.View.QLCafeDataModel {

    public class QLCafeMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Account> builder) {
			builder.DisplayName(QLCafeResources.Account);
						builder.Property(x => x.id).DisplayName(QLCafeResources.Account_id);
						builder.Property(x => x.DisplayName).DisplayName(QLCafeResources.Account_DisplayName);
						builder.Property(x => x.UserName).DisplayName(QLCafeResources.Account_UserName);
						builder.Property(x => x.Password).DisplayName(QLCafeResources.Account_Password);
						builder.Property(x => x.Type).DisplayName(QLCafeResources.Account_Type);
			        }
		        public static void BuildMetadata(MetadataBuilder<BillInfo> builder) {
			builder.DisplayName(QLCafeResources.BillInfo);
						builder.Property(x => x.id).DisplayName(QLCafeResources.BillInfo_id);
						builder.Property(x => x.count1).DisplayName(QLCafeResources.BillInfo_count1);
						builder.Property(x => x.Bill).DisplayName(QLCafeResources.BillInfo_Bill);
						builder.Property(x => x.Food).DisplayName(QLCafeResources.BillInfo_Food);
			        }
		        public static void BuildMetadata(MetadataBuilder<Bill> builder) {
			builder.DisplayName(QLCafeResources.Bill);
						builder.Property(x => x.id).DisplayName(QLCafeResources.Bill_id);
						builder.Property(x => x.DateCheckIn).DisplayName(QLCafeResources.Bill_DateCheckIn);
						builder.Property(x => x.DateCheckOut).DisplayName(QLCafeResources.Bill_DateCheckOut);
						builder.Property(x => x.status).DisplayName(QLCafeResources.Bill_status);
						builder.Property(x => x.Tablefood).DisplayName(QLCafeResources.Bill_Tablefood);
			        }
		        public static void BuildMetadata(MetadataBuilder<Tablefood> builder) {
			builder.DisplayName(QLCafeResources.Tablefood);
						builder.Property(x => x.id).DisplayName(QLCafeResources.Tablefood_id);
						builder.Property(x => x.name).DisplayName(QLCafeResources.Tablefood_name);
						builder.Property(x => x.status).DisplayName(QLCafeResources.Tablefood_status);
			        }
		        public static void BuildMetadata(MetadataBuilder<Food> builder) {
			builder.DisplayName(QLCafeResources.Food);
						builder.Property(x => x.id).DisplayName(QLCafeResources.Food_id);
						builder.Property(x => x.name).DisplayName(QLCafeResources.Food_name);
						builder.Property(x => x.idCategory).DisplayName(QLCafeResources.Food_idCategory);
						builder.Property(x => x.price).DisplayName(QLCafeResources.Food_price);
			        }
		        public static void BuildMetadata(MetadataBuilder<FoodCategory> builder) {
			builder.DisplayName(QLCafeResources.FoodCategory);
						builder.Property(x => x.id).DisplayName(QLCafeResources.FoodCategory_id);
						builder.Property(x => x.name).DisplayName(QLCafeResources.FoodCategory_name);
			        }
		    }
}