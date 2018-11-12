/* 
 * OAuth API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthorizationApiTests
    {
        private AuthorizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthorizationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationApi
            //Assert.IsInstanceOfType(typeof(AuthorizationApi), instance, "instance is a AuthorizationApi");
        }

        
        /// <summary>
        /// Test Authorize
        /// </summary>
        [Test]
        public void AuthorizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? aooUID = null;
            //string serviceUID = null;
            //string xAuthorization = null;
            //instance.Authorize(aooUID, serviceUID, xAuthorization);
            
        }
        
        /// <summary>
        /// Test Token
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenRequest request = null;
            //var response = instance.Token(request);
            //Assert.IsInstanceOf<TokenResponse> (response, "response is TokenResponse");
        }
        
    }

}
