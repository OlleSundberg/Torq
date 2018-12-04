﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torq.WPF.SchedualsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchedualsService.IScheduleService")]
    public interface IScheduleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/CreateSchedule", ReplyAction="http://tempuri.org/IScheduleService/CreateScheduleResponse")]
        Torq.Models.Objects.Schedule CreateSchedule(Torq.Models.Objects.Schedule schedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/CreateSchedule", ReplyAction="http://tempuri.org/IScheduleService/CreateScheduleResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> CreateScheduleAsync(Torq.Models.Objects.Schedule schedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetScheduleById", ReplyAction="http://tempuri.org/IScheduleService/GetScheduleByIdResponse")]
        Torq.Models.Objects.Schedule GetScheduleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetScheduleById", ReplyAction="http://tempuri.org/IScheduleService/GetScheduleByIdResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> GetScheduleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedules", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesResponse")]
        Torq.Models.Objects.Schedule[] GetSchedules();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedules", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByEmployee", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByEmployeeResponse")]
        Torq.Models.Objects.Schedule[] GetSchedulesByEmployee(Torq.Models.Objects.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByEmployee", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByEmployeeResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByEmployeeAsync(Torq.Models.Objects.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByDay", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByDayResponse")]
        Torq.Models.Objects.Schedule[] GetSchedulesByDay(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByDay", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByDayResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByDayAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByMonth", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByMonthResponse")]
        Torq.Models.Objects.Schedule[] GetSchedulesByMonth(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/GetSchedulesByMonth", ReplyAction="http://tempuri.org/IScheduleService/GetSchedulesByMonthResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByMonthAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/RemoveSchedule", ReplyAction="http://tempuri.org/IScheduleService/RemoveScheduleResponse")]
        void RemoveSchedule(Torq.Models.Objects.Schedule schedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/RemoveSchedule", ReplyAction="http://tempuri.org/IScheduleService/RemoveScheduleResponse")]
        System.Threading.Tasks.Task RemoveScheduleAsync(Torq.Models.Objects.Schedule schedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/UpdateSchedule", ReplyAction="http://tempuri.org/IScheduleService/UpdateScheduleResponse")]
        Torq.Models.Objects.Schedule UpdateSchedule(Torq.Models.Objects.Schedule schedule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduleService/UpdateSchedule", ReplyAction="http://tempuri.org/IScheduleService/UpdateScheduleResponse")]
        System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> UpdateScheduleAsync(Torq.Models.Objects.Schedule schedule);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScheduleServiceChannel : Torq.WPF.SchedualsService.IScheduleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScheduleServiceClient : System.ServiceModel.ClientBase<Torq.WPF.SchedualsService.IScheduleService>, Torq.WPF.SchedualsService.IScheduleService {
        
        public ScheduleServiceClient() {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScheduleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Torq.Models.Objects.Schedule CreateSchedule(Torq.Models.Objects.Schedule schedule) {
            return base.Channel.CreateSchedule(schedule);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> CreateScheduleAsync(Torq.Models.Objects.Schedule schedule) {
            return base.Channel.CreateScheduleAsync(schedule);
        }
        
        public Torq.Models.Objects.Schedule GetScheduleById(int id) {
            return base.Channel.GetScheduleById(id);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> GetScheduleByIdAsync(int id) {
            return base.Channel.GetScheduleByIdAsync(id);
        }
        
        public Torq.Models.Objects.Schedule[] GetSchedules() {
            return base.Channel.GetSchedules();
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesAsync() {
            return base.Channel.GetSchedulesAsync();
        }
        
        public Torq.Models.Objects.Schedule[] GetSchedulesByEmployee(Torq.Models.Objects.Employee employee) {
            return base.Channel.GetSchedulesByEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByEmployeeAsync(Torq.Models.Objects.Employee employee) {
            return base.Channel.GetSchedulesByEmployeeAsync(employee);
        }
        
        public Torq.Models.Objects.Schedule[] GetSchedulesByDay(System.DateTime date) {
            return base.Channel.GetSchedulesByDay(date);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByDayAsync(System.DateTime date) {
            return base.Channel.GetSchedulesByDayAsync(date);
        }
        
        public Torq.Models.Objects.Schedule[] GetSchedulesByMonth(System.DateTime date) {
            return base.Channel.GetSchedulesByMonth(date);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule[]> GetSchedulesByMonthAsync(System.DateTime date) {
            return base.Channel.GetSchedulesByMonthAsync(date);
        }
        
        public void RemoveSchedule(Torq.Models.Objects.Schedule schedule) {
            base.Channel.RemoveSchedule(schedule);
        }
        
        public System.Threading.Tasks.Task RemoveScheduleAsync(Torq.Models.Objects.Schedule schedule) {
            return base.Channel.RemoveScheduleAsync(schedule);
        }
        
        public Torq.Models.Objects.Schedule UpdateSchedule(Torq.Models.Objects.Schedule schedule) {
            return base.Channel.UpdateSchedule(schedule);
        }
        
        public System.Threading.Tasks.Task<Torq.Models.Objects.Schedule> UpdateScheduleAsync(Torq.Models.Objects.Schedule schedule) {
            return base.Channel.UpdateScheduleAsync(schedule);
        }
    }
}