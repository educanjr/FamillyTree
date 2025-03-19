import { fetchFamilyWithMembers } from "@/api-queries/fetchFamilyWithMembers";
import FamilyGrid from "@/componets/family-grid/family-grid";

import styles from './page.module.css';
import GoHome from "@/componets/go-home/go-home";

interface FamilyPageParams {
    familyId: string;
}

interface FamilyPageProps {
    params: Promise<FamilyPageParams>;
}

export default async function FamilyPage({params}: FamilyPageProps) {
    const { familyId } = await params;
    return (        
        <>
            <div className={styles['button-container']}>
                <GoHome />
            </div>
            <FamilyData familyId={familyId} />
        </>
    )
}

async function tryFetchFamilyData(familyId: string) {
    try {
        return await fetchFamilyWithMembers(familyId);
    } catch (error) {
        console.error("Error fetching family:", error);
        return null;
    }
}

async function FamilyData({familyId}: FamilyPageParams) {
    const family = await tryFetchFamilyData(familyId);

    return (
        <>
            {family && family?.members && (<FamilyGrid familyMembers={family?.members} />)}
        </>
    )
}