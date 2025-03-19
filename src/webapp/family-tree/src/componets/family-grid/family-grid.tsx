'use client' 

import styles from './family-grid.module.css';
import { FamilyMemberApiResponse } from '@/Interfaces/familyApiResponse';
import FamilyMember from './family-member';

interface FamilyGridProps {
    familyMembers: FamilyMemberApiResponse[]
}

export default function FamilyGrid({ familyMembers }: FamilyGridProps) {
  return (        
    <ul className={styles['family-grid']}>
        {familyMembers.map((member) => (
            <li key={member.id}>
            <FamilyMember familyMember={member} />
            </li>
        ))}
    </ul>
    
  );
}