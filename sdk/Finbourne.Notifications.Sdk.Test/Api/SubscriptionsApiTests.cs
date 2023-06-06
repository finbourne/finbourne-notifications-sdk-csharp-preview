/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Finbourne.Notifications.Sdk.Client;
using Finbourne.Notifications.Sdk.Api;
// uncomment below to import models
//using Finbourne.Notifications.Sdk.Model;

namespace Finbourne.Notifications.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing SubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubscriptionsApiTests : IDisposable
    {
        private SubscriptionsApi instance;

        public SubscriptionsApiTests()
        {
            instance = new SubscriptionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubscriptionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SubscriptionsApi
            //Assert.IsType<SubscriptionsApi>(instance);
        }

        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Fact]
        public void CreateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateSubscription createSubscription = null;
            //var response = instance.CreateSubscription(createSubscription);
            //Assert.IsType<Subscription>(response);
        }

        /// <summary>
        /// Test DeleteSubscription
        /// </summary>
        [Fact]
        public void DeleteSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scope = null;
            //string code = null;
            //instance.DeleteSubscription(scope, code);
        }

        /// <summary>
        /// Test GetSubscription
        /// </summary>
        [Fact]
        public void GetSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scope = null;
            //string code = null;
            //var response = instance.GetSubscription(scope, code);
            //Assert.IsType<Subscription>(response);
        }

        /// <summary>
        /// Test ListSubscriptions
        /// </summary>
        [Fact]
        public void ListSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string sortBy = null;
            //string page = null;
            //int? limit = null;
            //var response = instance.ListSubscriptions(filter, sortBy, page, limit);
            //Assert.IsType<ResourceListOfSubscription>(response);
        }

        /// <summary>
        /// Test UpdateSubscription
        /// </summary>
        [Fact]
        public void UpdateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scope = null;
            //string code = null;
            //UpdateSubscription updateSubscription = null;
            //var response = instance.UpdateSubscription(scope, code, updateSubscription);
            //Assert.IsType<Subscription>(response);
        }
    }
}