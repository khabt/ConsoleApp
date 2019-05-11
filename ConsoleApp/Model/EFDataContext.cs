namespace ConsoleApp.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDataContext : DbContext
    {
        public EFDataContext()
            : base("name=Data")
        {
        }

        public virtual DbSet<AdjustInv> AdjustInvs { get; set; }
        public virtual DbSet<AdjustInvTemp> AdjustInvTemps { get; set; }
        public virtual DbSet<ApprovalStep> ApprovalSteps { get; set; }
        public virtual DbSet<ApprovalWorkFlow> ApprovalWorkFlows { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<BusinessLog> BusinessLogs { get; set; }
        public virtual DbSet<CategoryArticle> CategoryArticles { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractAttach> ContractAttaches { get; set; }
        public virtual DbSet<ContractPackage> ContractPackages { get; set; }
        public virtual DbSet<ContractProduct> ContractProducts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Decision> Decisions { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<GroupProduct> GroupProducts { get; set; }
        public virtual DbSet<InvAttach> InvAttaches { get; set; }
        public virtual DbSet<InvCancel> InvCancels { get; set; }
        public virtual DbSet<InvCancelDetail> InvCancelDetails { get; set; }
        public virtual DbSet<InvCategory> InvCategories { get; set; }
        public virtual DbSet<InvCertify> InvCertifies { get; set; }
        public virtual DbSet<InvDeliver> InvDelivers { get; set; }
        public virtual DbSet<OutwardStock> OutwardStocks { get; set; }
        public virtual DbSet<PaymentTransactionData> PaymentTransactionDatas { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<ProductOStock> ProductOStocks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Publish> Publishes { get; set; }
        public virtual DbSet<PublishInvoice> PublishInvoices { get; set; }
        public virtual DbSet<PublishTemp> PublishTemps { get; set; }
        public virtual DbSet<PurchaseInvAttach> PurchaseInvAttaches { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<PurchaseInvProd> PurchaseInvProds { get; set; }
        public virtual DbSet<RecordsInv> RecordsInvs { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<SendEmail> SendEmails { get; set; }
        public virtual DbSet<SendSm> SendSms { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<TaxAuthority> TaxAuthorities { get; set; }
        public virtual DbSet<TransactionData> TransactionDatas { get; set; }
        public virtual DbSet<userdata> userdatas { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<VATConversion> VATConversions { get; set; }
        public virtual DbSet<VATInvoice> VATInvoices { get; set; }
        public virtual DbSet<ProductInv> ProductInvs { get; set; }
        public virtual DbSet<role_permission> role_permission { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>()
                .Property(e => e.CurrencyType)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ExchangeValue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract>()
                .Property(e => e.LiquidatedValue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ContractProduct>()
                .Property(e => e.QuantityRequired)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ContractProduct>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<GroupProduct>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<InvCancelDetail>()
                .Property(e => e.FromNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvCancelDetail>()
                .Property(e => e.ToNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvCertify>()
                .Property(e => e.No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvDeliver>()
                .Property(e => e.No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.OriginalTotal)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.OriginalDiscount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.OriginalAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.VNDTotal)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.VNDDiscount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OutwardStock>()
                .Property(e => e.VNDAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.Price)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.Discount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.InQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.OutQuantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.Total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductOStock>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Product>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<PublishInvoice>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PublishInvoice>()
                .Property(e => e.FromNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PublishInvoice>()
                .Property(e => e.ToNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PublishInvoice>()
                .Property(e => e.CurrentNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PublishInvoice>()
                .Property(e => e.SerialDivisionMark)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseInvoice>()
                .Property(e => e.Total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.VATRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.VATAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.Extra)
                .IsFixedLength();

            modelBuilder.Entity<PurchaseInvProd>()
                .Property(e => e.ComID)
                .IsFixedLength();

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.Total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.VATAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.GrossValue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.VatAmount0)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.GrossValue0)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.VatAmount5)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.GrossValue5)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.VatAmount10)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.GrossValue10)
                .HasPrecision(18, 3);

            modelBuilder.Entity<VATInvoice>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.Total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.VATAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ProductInv>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);
        }
    }
}
