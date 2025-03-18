export interface FamilyListApiResponse {
    families: FamilyListItemApiResponse[];
}

export interface FamilyListItemApiResponse {
    id: string;
    name: string;
}