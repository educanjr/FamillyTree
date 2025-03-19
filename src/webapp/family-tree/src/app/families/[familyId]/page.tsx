import { fetchFamilyWithMembers } from "@/api-queries/fetchFamilyWithMembers";
import FamilyGrid from "@/componets/family-grid/family-grid";
import { FamilyApiResponse } from "@/Interfaces/familyApiResponse";

import styles from './page.module.css';
import GoHome from "@/componets/go-home/go-home";


interface PageProps {
    params: {familyId: string};
}

export default async function FamilyPage({params}: PageProps) {
    let family: FamilyApiResponse | null = null;
    try {        
        family = await fetchFamilyWithMembers(params.familyId);
    } catch (error) {
        console.error("Error fetching family:", error);
    }

    return (        
        <>
            <div className={styles['button-container']}>
                <GoHome />
            </div>
            {family && family?.members && (<FamilyGrid familyMembers={family?.members} />)}
        </>
    )
}