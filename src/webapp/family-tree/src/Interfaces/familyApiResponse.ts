export interface FamilyApiResponse {
    id: string;
    name: string;
    members: FamilyMemberApiResponse[];
}

export interface FamilyMemberApiResponse {
    id: string;
    givenName: string;
    surname: string;
    gender: 'Male' | 'Female' | 'Other';
    lifespan: string;
}