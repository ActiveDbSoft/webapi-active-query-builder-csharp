/* 
 * QueryBuilderApi
 *
 * Active Query Builder Web API lets create, analyze and modify SQL queries for different database servers using RESTful HTTP requests to a cloud-based service. It requires SQL execution context (information about database schema and used database server) to be stored under the registered account at https://webapi.activequerybuilder.com/.
 *
 * OpenAPI spec version: 1.1.8
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApi.ActiveQueryBuilder.Model
{
    /// <summary>
    /// Information about SQL query and it&#39;s context.
    /// </summary>
    [DataContract]
    public partial class SqlQuery :  IEquatable<SqlQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlQuery" /> class.
        /// </summary>
        /// <param name="Guid">Unique identifier that defines SQL execution context for the given query, i.e. database server (SQL syntax rules),  database schema. The context itself must be saved in the user account on https://webapi.activequerybuilder.com/..</param>
        /// <param name="Text">SQL query text..</param>
	public SqlQuery() {}
        public SqlQuery(string Guid = null, string Text = null)
        {
            this.Guid = Guid;
            this.Text = Text;
        }
        
        /// <summary>
        /// Unique identifier that defines SQL execution context for the given query, i.e. database server (SQL syntax rules),  database schema. The context itself must be saved in the user account on https://webapi.activequerybuilder.com/.
        /// </summary>
        /// <value>Unique identifier that defines SQL execution context for the given query, i.e. database server (SQL syntax rules),  database schema. The context itself must be saved in the user account on https://webapi.activequerybuilder.com/.</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }
        /// <summary>
        /// SQL query text.
        /// </summary>
        /// <value>SQL query text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlQuery {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SqlQuery);
        }

        /// <summary>
        /// Returns true if SqlQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of SqlQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                return hash;
            }
        }
    }

}
