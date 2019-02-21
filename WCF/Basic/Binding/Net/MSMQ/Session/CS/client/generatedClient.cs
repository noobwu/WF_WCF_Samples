﻿//----------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//----------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.MSMQSessionSample
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.Samples.MSMQSessionSample", ConfigurationName="Microsoft.Samples.MSMQSessionSample.IOrderTaker", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IOrderTaker
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.MSMQSessionSample/IOrderTaker/OpenPurchaseOrder")]
        void OpenPurchaseOrder(string customerId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.MSMQSessionSample/IOrderTaker/AddProductLineItem")]
        void AddProductLineItem(string productId, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.Samples.MSMQSessionSample/IOrderTaker/EndPurchaseOrder")]
        void EndPurchaseOrder();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderTakerChannel : Microsoft.Samples.MSMQSessionSample.IOrderTaker, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderTakerClient : System.ServiceModel.ClientBase<Microsoft.Samples.MSMQSessionSample.IOrderTaker>, Microsoft.Samples.MSMQSessionSample.IOrderTaker
    {
        
        public OrderTakerClient()
        {
        }
        
        public OrderTakerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public OrderTakerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OrderTakerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OrderTakerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void OpenPurchaseOrder(string customerId)
        {
            base.Channel.OpenPurchaseOrder(customerId);
        }
        
        public void AddProductLineItem(string productId, int quantity)
        {
            base.Channel.AddProductLineItem(productId, quantity);
        }
        
        public void EndPurchaseOrder()
        {
            base.Channel.EndPurchaseOrder();
        }
    }
}