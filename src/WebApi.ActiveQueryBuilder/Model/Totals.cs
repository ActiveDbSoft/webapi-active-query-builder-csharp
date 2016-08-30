/* 
 * QueryBuilderApi
 *
 * Active Query Builder Web API lets create, analyze and modify SQL queries for different database servers using RESTful HTTP requests to a cloud-based service. It requires SQL execution context (information about database schema and used database server) to be stored under the registered account at https://webapi.activequerybuilder.com/.
 *
 * OpenAPI spec version: 1.1.3
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
    /// If any aggregations are defined there, the SELECT list of original query is replaced with the list of aggregations in transformed query. Filling aggregations is useful when you want to get totals for original query resultset.
    /// </summary>
    [DataContract]
    public partial class Totals :  IEquatable<Totals>
    {
        /// <summary>
        /// Aggregate function name.
        /// </summary>
        /// <value>Aggregate function name.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregateEnum
        {
            
            /// <summary>
            /// Enum Avg for "avg"
            /// </summary>
            [EnumMember(Value = "avg")]
            Avg,
            
            /// <summary>
            /// Enum Count for "count"
            /// </summary>
            [EnumMember(Value = "count")]
            Count,
            
            /// <summary>
            /// Enum Max for "max"
            /// </summary>
            [EnumMember(Value = "max")]
            Max,
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Sum for "sum"
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum
        }

        /// <summary>
        /// Aggregate function name.
        /// </summary>
        /// <value>Aggregate function name.</value>
        [DataMember(Name="aggregate", EmitDefaultValue=false)]
        public AggregateEnum? Aggregate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Totals" /> class.
        /// </summary>
        /// <param name="Field">Column of original query to which an aggregate function will be applied..</param>
        /// <param name="Aggregate">Aggregate function name..</param>
	public Totals() {}
        public Totals(string Field = null, AggregateEnum? Aggregate = null)
        {
            this.Field = Field;
            this.Aggregate = Aggregate;
        }
        
        /// <summary>
        /// Column of original query to which an aggregate function will be applied.
        /// </summary>
        /// <value>Column of original query to which an aggregate function will be applied.</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Totals {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Aggregate: ").Append(Aggregate).Append("\n");
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
            return this.Equals(obj as Totals);
        }

        /// <summary>
        /// Returns true if Totals instances are equal
        /// </summary>
        /// <param name="other">Instance of Totals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Totals other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Aggregate == other.Aggregate ||
                    this.Aggregate != null &&
                    this.Aggregate.Equals(other.Aggregate)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Aggregate != null)
                    hash = hash * 59 + this.Aggregate.GetHashCode();
                return hash;
            }
        }
    }

}