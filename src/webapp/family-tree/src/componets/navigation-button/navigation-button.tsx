import styles from './navigation-button.module.css';

interface NavigationButtonProps {
    label: string;
    onClick: () => void;
    isActive: boolean;
}

export default function NavigationButton({ label, onClick, isActive = true }: NavigationButtonProps) {
    const handleClick = () => {
        if (isActive) {
            onClick();
        }
    }

    const getButtonClassName = () => `${styles['navigate-button']} ${isActive ? '' : styles['disabled']}` 

    return (
        <button className={getButtonClassName()} onClick={handleClick}>
            <span>
                {label}
            </span>
        </button>
    );
}