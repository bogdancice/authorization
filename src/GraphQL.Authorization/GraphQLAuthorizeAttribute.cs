using GraphQL.Utilities;

namespace GraphQL.Authorization
{
    /// <summary>
    /// Attribute to apply authorization policy when using schema first approach.
    /// </summary>
    public class GraphQLAuthorizeAttribute : GraphQLAttribute
    {
        /// <summary>
        /// The name of policy to apply.
        /// </summary>
        public string Policy { get; set; }

        /// <inheritdoc />
        public override void Modify(TypeConfig type) => type.AuthorizeWith(Policy);

        /// <inheritdoc />
        public override void Modify(FieldConfig field) => field.AuthorizeWith(Policy);
    }
}
