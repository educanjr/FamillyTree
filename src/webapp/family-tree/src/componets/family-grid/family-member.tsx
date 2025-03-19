import { FamilyMemberApiResponse } from '@/Interfaces/familyApiResponse';

import styles from './family-member.module.css'

interface FamilyMemberProps {
    familyMember: FamilyMemberApiResponse
}

export default function FamilyMember({ familyMember }: FamilyMemberProps) {
  const getClassName = () => {
    switch (familyMember.gender) {
      case "Male":
          return `${styles['family-member']} ${styles['male']}`;
      case "Female":
          return `${styles['family-member']} ${styles['female']}`;
      default:
          return styles['family-member'];
    }
  };

  return (
    <article className={getClassName()}>
      <header>
        <div className={styles['header-text']}>
          <h2>{familyMember.surname} {familyMember.givenName}</h2>
          <p>{familyMember.gender}</p>
        </div>
      </header>
      <div className={styles['content']}>
        <p className={styles['summary']}>{familyMember.lifespan}</p>
      </div>
    </article>
  );
}