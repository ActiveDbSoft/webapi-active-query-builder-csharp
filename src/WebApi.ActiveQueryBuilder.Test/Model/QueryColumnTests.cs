/* 
 * QueryBuilderApi
 *
 * Active Query Builder Web API lets create, analyze and modify SQL queries for different database servers using RESTful HTTP requests to a cloud-based service. It requires SQL execution context (information about database schema and used database server) to be stored under the registered account at https://webapi.activequerybuilder.com/.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@activedbsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Model;
using WebApi.ActiveQueryBuilder.Client;
using System.Reflection;

namespace WebApi.ActiveQueryBuilder.Test
{
    /// <summary>
    ///  Class for testing QueryColumn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QueryColumnTests
    {
        // TODO uncomment below to declare an instance variable for QueryColumn
        //private QueryColumn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of QueryColumn
            //instance = new QueryColumn();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QueryColumn
        /// </summary>
        [Test]
        public void QueryColumnInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" QueryColumn
            //Assert.IsInstanceOfType<QueryColumn> (instance, "variable 'instance' is a QueryColumn");
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'DataType'
        /// </summary>
        [Test]
        public void DataTypeTest()
        {
            // TODO unit test for the property 'DataType'
        }

    }

}
