﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torq.MVC.EmployeesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Torq.Models.Objects")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOnlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Torq.MVC.EmployeesService.Role RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsOnline {
            get {
                return this.IsOnlineField;
            }
            set {
                if ((this.IsOnlineField.Equals(value) != true)) {
                    this.IsOnlineField = value;
                    this.RaisePropertyChanged("IsOnline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Torq.MVC.EmployeesService.Role Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/Torq.Models.Objects")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeesService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        Torq.MVC.EmployeesService.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        Torq.MVC.EmployeesService.Employee GetEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> GetEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeByUserName", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByUserNameResponse")]
        Torq.MVC.EmployeesService.Employee GetEmployeeByUserName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeByUserName", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByUserNameResponse")]
        System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> GetEmployeeByUserNameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        Torq.MVC.EmployeesService.Employee UpdateEmployee(Torq.MVC.EmployeesService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> UpdateEmployeeAsync(Torq.MVC.EmployeesService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/RemoveEmployeeResponse")]
        void RemoveEmployee(Torq.MVC.EmployeesService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RemoveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task RemoveEmployeeAsync(Torq.MVC.EmployeesService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/CreateEmployeeResponse")]
        Torq.MVC.EmployeesService.Employee CreateEmployee(Torq.MVC.EmployeesService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> CreateEmployeeAsync(Torq.MVC.EmployeesService.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Torq.MVC.EmployeesService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Torq.MVC.EmployeesService.IEmployeeService>, Torq.MVC.EmployeesService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Torq.MVC.EmployeesService.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public Torq.MVC.EmployeesService.Employee GetEmployeeById(int id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> GetEmployeeByIdAsync(int id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public Torq.MVC.EmployeesService.Employee GetEmployeeByUserName(string userName) {
            return base.Channel.GetEmployeeByUserName(userName);
        }
        
        public System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> GetEmployeeByUserNameAsync(string userName) {
            return base.Channel.GetEmployeeByUserNameAsync(userName);
        }
        
        public Torq.MVC.EmployeesService.Employee UpdateEmployee(Torq.MVC.EmployeesService.Employee employee) {
            return base.Channel.UpdateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> UpdateEmployeeAsync(Torq.MVC.EmployeesService.Employee employee) {
            return base.Channel.UpdateEmployeeAsync(employee);
        }
        
        public void RemoveEmployee(Torq.MVC.EmployeesService.Employee employee) {
            base.Channel.RemoveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task RemoveEmployeeAsync(Torq.MVC.EmployeesService.Employee employee) {
            return base.Channel.RemoveEmployeeAsync(employee);
        }
        
        public Torq.MVC.EmployeesService.Employee CreateEmployee(Torq.MVC.EmployeesService.Employee employee) {
            return base.Channel.CreateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<Torq.MVC.EmployeesService.Employee> CreateEmployeeAsync(Torq.MVC.EmployeesService.Employee employee) {
            return base.Channel.CreateEmployeeAsync(employee);
        }
    }
}
