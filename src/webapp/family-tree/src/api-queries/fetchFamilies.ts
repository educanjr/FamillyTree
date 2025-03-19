import { FamilyListApiResponse } from "@/Interfaces/familyListApiResponse";

export async function fetchFamilies(): Promise<FamilyListApiResponse> {
    const baseApiUrl = process.env.NEXT_PUBLIC_API_BASE_URL; // Load from env
    const clientId = process.env.NEXT_PUBLIC_X_CLIENT_ID; // Load from env

    if (!baseApiUrl || !clientId) {
        console.error("Missing API base URL or client ID in environment variables.");
        return defaultFamilyResponse;
    }

    const apiUrl = `${baseApiUrl}/v1/Families`

    try {
        const response = await fetch(`${apiUrl}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'x-client-id': clientId, // Custom header from env
            },
            cache: 'no-store',
        });

        if (!response.ok) {
            throw new Error(`API request failed: ${response.statusText}`);
        }

        const family: FamilyListApiResponse = await response.json();
        return family;
    } catch (error) {
        console.error("Error fetching family data:", error);
        return defaultFamilyResponse;
    }
}

const defaultFamilyResponse: FamilyListApiResponse = { families: [] };