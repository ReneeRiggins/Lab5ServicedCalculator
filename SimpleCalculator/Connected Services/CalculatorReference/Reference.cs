﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleCalculator.CalculatorReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorReference.CalculatorSoap")]
    public interface CalculatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        double Add(double f1, double f2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtrct", ReplyAction="*")]
        double Subtrct(double f1, double f2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        double Multiply(double f1, double f2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        double Divide(double f1, double f2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Neg", ReplyAction="*")]
        double Neg(double f1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : SimpleCalculator.CalculatorReference.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<SimpleCalculator.CalculatorReference.CalculatorSoap>, SimpleCalculator.CalculatorReference.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double f1, double f2) {
            return base.Channel.Add(f1, f2);
        }
        
        public double Subtrct(double f1, double f2) {
            return base.Channel.Subtrct(f1, f2);
        }
        
        public double Multiply(double f1, double f2) {
            return base.Channel.Multiply(f1, f2);
        }
        
        public double Divide(double f1, double f2) {
            return base.Channel.Divide(f1, f2);
        }
        
        public double Neg(double f1) {
            return base.Channel.Neg(f1);
        }
    }
}
