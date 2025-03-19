import { fetchFamilyWithMembers } from "@/api-queries/fetchFamilyWithMembers";
import FamilyGrid from "@/componets/family-grid/family-grid";

import styles from './page.module.css';
import GoHome from "@/componets/go-home/go-home";


interface PageProps {
    params: {familyId: string};
}

export default async function FamilyPage({params}: PageProps) {
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

interface FamilyDataProps {
    familyId: string;
}

async function tryFetchFamilyData(familyId: string) {
    try {
        return await fetchFamilyWithMembers(familyId);
    } catch (error) {
        console.error("Error fetching family:", error);
        return null;
    }
}

async function FamilyData({familyId}: FamilyDataProps) {
    const family = await tryFetchFamilyData(familyId);

    return (
        <>
            {family && family?.members && (<FamilyGrid familyMembers={family?.members} />)}
        </>
    )
}