<h2 align='center'> MVC </h2>

<strong> Base IRepositoryAsync Generic Type  </strong>
- IRepositoryAsync<T> where T: class
  - Task<int> InsertAsync(T entity);
  - Task<int> UpdateAsync(T entity);
  - Task<int> DeleteAsync(int id);
  - Task<T> GetByIdAsync(int id);
  - Task<IEnumerable<T>> GetAllAsync();
  
<strong>Inherit Base IRepositoryAsync with a specific class type </strong>
- IProductRepositoryAsync: IRepositoryAsync<Product> 
  
<strong> For confidential purpose: hide confidential information </strong>
- Core/Model: 
    - IProductServiceAsync
        - Task<IEnumerable<EmployeeResponseModel>> GetAllAsync();
        - Task<int> AddEmployeeAsync(EmployeeRequestModel employee);
        - Task<EmployeeResponseModel> GetByIdAsync(int id);
        - Task<EmployeeRequestModel> GetEmployeeForEditAsync(int id);
        - Task<int> UpdateEmployeeAsync(EmployeeRequestModel employee);
        - Task<int> DeleteEmployeeAsync(int id);
- Core/Service: 
  EmployeeRequestModel
[Required, Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(5)]
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        [Required, Column(TypeName = "varchar")]
        [MaxLength(80)]
        public string Address { get; set; }
        [Required, Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string City { get; set; }
        public int RegionId { get; set; }
        public int PostalCode { get; set; }
        [Required, Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Country { get; set; }
        [Required, Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string Phone { get; set; }
        public int? ReportsTo { get; set; }
        [Required, Column(TypeName = "varchar(max)")]
        public string PhotoPath { get; set; }
public class EmployeeResponseModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoPath { get; set; }
        public string Phone { get; set; }
    }
  




