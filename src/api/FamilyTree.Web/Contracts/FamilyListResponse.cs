namespace FamilyTree.Web.Contracts;

internal record FamilyListResponse(List<FamilyListItemResponse> Families);

internal record FamilyListItemResponse(
    Guid Id,
    string Name);
